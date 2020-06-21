package br.unifor.dispositivos.ginder.data.model

import com.fasterxml.jackson.annotation.JsonInclude
import java.util.*

@JsonInclude(JsonInclude.Include.NON_EMPTY)
public class PlayerGame(Id: UUID, val PlayerId: UUID, val GameId: UUID, val PeriodTime: String, val Role: String, val Game: Game): Entity(Id) {
}
