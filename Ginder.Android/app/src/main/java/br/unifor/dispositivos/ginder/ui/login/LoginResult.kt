package br.unifor.dispositivos.ginder.ui.login

import br.unifor.dispositivos.ginder.data.model.Player

/**
 * Authentication result : success (user details) or error message.
 */
data class LoginResult(
        val success: LoggedInUserView? = null,
        val error: Int? = null,
        val player: Player?
)
