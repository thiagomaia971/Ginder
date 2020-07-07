package br.unifor.dispositivos.ginder.data

import br.unifor.dispositivos.ginder.data.model.LocationValueObject
import com.github.kittinunf.fuel.core.Request
import com.github.kittinunf.fuel.httpGet
import java.util.*

public class PlayerGameRepository: Repository() {
    override var actionUrl: String = "/api/PlayersGame"

    fun getAll(playerId: String, gamerId: String, distance: Double, location: LocationValueObject): Request {
        val url = "${CreateUrl()}/${Encode(playerId.toString())}/${Encode(gamerId.toString())}/${Encode(distance.toString())}/${Encode(location.Latidude.toString())}/${Encode(location.Longitude.toString())}"
        return url.httpGet()
    }
}