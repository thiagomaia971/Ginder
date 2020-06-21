package br.unifor.dispositivos.ginder.ui.perfil

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.lifecycle.ViewModelProviders
import br.unifor.dispositivos.ginder.R
import br.unifor.dispositivos.ginder.data.PlayerRepository
import br.unifor.dispositivos.ginder.data.model.Game
import br.unifor.dispositivos.ginder.data.model.Player
import br.unifor.dispositivos.ginder.data.model.PlayerGame
import br.unifor.dispositivos.ginder.data.model.RequestResult
import br.unifor.dispositivos.ginder.ui.login.LoggedInUserView
import br.unifor.dispositivos.ginder.ui.login.LoginResult
import br.unifor.dispositivos.ginder.ui.login.LoginViewModel
import br.unifor.dispositivos.ginder.ui.login.LoginViewModelFactory
import com.fasterxml.jackson.databind.DeserializationFeature
import com.fasterxml.jackson.module.kotlin.jacksonObjectMapper
import com.fasterxml.jackson.module.kotlin.readValue
import kotlinx.android.synthetic.main.activity_perfil.*
import java.util.*

class PerfilActivity : AppCompatActivity() {
    private lateinit var loginViewModel: LoginViewModel

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_perfil)

        val playerId = intent.getStringExtra("playerId")
        PlayerRepository().getSingle(UUID.fromString(playerId))
            .responseString { request, response, result ->
                when(result){
                    is com.github.kittinunf.result.Result.Success -> {
                        val mapper = jacksonObjectMapper().configure(DeserializationFeature.FAIL_ON_UNKNOWN_PROPERTIES, false)
                        val playerResult = mapper.readValue<RequestResult<Player>>(result.value)
                        playergame_list.adapter = PlayerGameAdapter(this, R.layout.playergame_item, playerResult.Result.Games)
                    }
                    is com.github.kittinunf.result.Result.Failure -> {

                    }
                }
            }

//        playergame_list.setOnItemClickListener { parent, view, position, id ->
//            Toast.makeText(this, meusJogos[position], Toast.LENGTH_SHORT).show()
//        }
    }
}
