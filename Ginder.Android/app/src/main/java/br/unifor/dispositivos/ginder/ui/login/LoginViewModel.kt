package br.unifor.dispositivos.ginder.ui.login

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import android.util.Patterns
import br.unifor.dispositivos.ginder.data.LoginRepository
import br.unifor.dispositivos.ginder.data.model.Player

import br.unifor.dispositivos.ginder.R
import br.unifor.dispositivos.ginder.data.model.RequestResult

import com.fasterxml.jackson.databind.DeserializationFeature
import com.fasterxml.jackson.module.kotlin.jacksonObjectMapper
import com.fasterxml.jackson.module.kotlin.readValue

class LoginViewModel(private val loginRepository: LoginRepository) : ViewModel() {
    private val _loginForm = MutableLiveData<LoginFormState>()
    val loginFormState: LiveData<LoginFormState> = _loginForm

    private val _loginResult = MutableLiveData<LoginResult>()
    val loginResult: LiveData<LoginResult> = _loginResult

    fun login(username: String, password: String) {
        loginRepository.login(username, password)
            .responseString { request, response, result ->
                when(result){
                    is com.github.kittinunf.result.Result.Success -> {
                        val mapper = jacksonObjectMapper().configure(DeserializationFeature.FAIL_ON_UNKNOWN_PROPERTIES, false)
                        val playerResult = mapper.readValue<RequestResult<Player>>(result.value)

                        _loginResult.value = LoginResult(LoggedInUserView(displayName = playerResult.Result.Name), null, playerResult.Result)
                        println("Result: ${playerResult}")
                    }
                    is com.github.kittinunf.result.Result.Failure -> {
                        _loginResult.value = LoginResult(error = R.string.login_failed, player = null)
                    }
                }
            }
    }

    fun loginDataChanged(username: String, password: String) {
        if (!isUserNameValid(username)) {
            _loginForm.value = LoginFormState(usernameError = R.string.invalid_username)
        } else if (!isPasswordValid(password)) {
            _loginForm.value = LoginFormState(passwordError = R.string.invalid_password)
        } else {
            _loginForm.value = LoginFormState(isDataValid = true)
        }
    }

    // A placeholder username validation check
    private fun isUserNameValid(username: String): Boolean {
        return if (username.contains('@')) {
            Patterns.EMAIL_ADDRESS.matcher(username).matches()
        } else {
            username.isNotBlank()
        }
    }

    // A placeholder password validation check
    private fun isPasswordValid(password: String): Boolean {
        return password.length > 0
    }
}
