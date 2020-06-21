package br.unifor.dispositivos.ginder.data.model

import java.time.OffsetDateTime
import java.util.*

public abstract class Entity(val Id: UUID) {
}

public class Player(Id: UUID, val Name: String, val Idade: Int, val Location: LocationValueObject?, val Games: List<PlayerGame>)
    : Entity(Id) {
}

public class LocationValueObject (val Latidude: Double, val Longitude: Double) {

}