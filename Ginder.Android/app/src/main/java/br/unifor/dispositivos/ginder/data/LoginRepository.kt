package br.unifor.dispositivos.ginder.data

import br.unifor.dispositivos.ginder.data.model.Player
import com.github.kittinunf.fuel.core.Request
import com.github.kittinunf.fuel.httpGet

public class LoginRepository : Repository() {
    override var actionUrl: String = "/api/Users/login"

    var user: Player? = null
        private set

    val isLoggedIn: Boolean
        get() = user != null

    init {
        user = null
    }

    fun login(login: String, password: String): Request {
        val url = "${CreateUrl()}/${Encode(login)}/${Encode(password)}"
        return url.httpGet()
    }
}

