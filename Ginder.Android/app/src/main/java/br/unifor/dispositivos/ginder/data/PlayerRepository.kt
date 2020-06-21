package br.unifor.dispositivos.ginder.data

import com.github.kittinunf.fuel.core.Request
import com.github.kittinunf.fuel.httpGet
import java.util.*

public class PlayerRepository: Repository() {
    override var actionUrl: String = "/api/Players"

    fun getSingle(id: UUID): Request {
        val url = "${CreateUrl()}/${Encode(id.toString())}"
        return url.httpGet()
    }
}