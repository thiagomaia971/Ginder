package br.unifor.dispositivos.ginder.ui.search

import android.Manifest
import android.content.Intent
import android.location.Location
import android.location.LocationListener
import android.location.LocationManager
import android.os.Bundle
import android.util.Log
import android.widget.TextView
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import androidx.core.app.ActivityCompat
import br.unifor.dispositivos.ginder.R
import br.unifor.dispositivos.ginder.data.PlayerGameRepository
import br.unifor.dispositivos.ginder.data.model.LocationValueObject
import br.unifor.dispositivos.ginder.data.model.PlayerGame
import br.unifor.dispositivos.ginder.data.model.RequestResult
import br.unifor.dispositivos.ginder.ui.perfil.PlayerGameAdapter
import com.fasterxml.jackson.databind.DeserializationFeature
import com.fasterxml.jackson.module.kotlin.jacksonObjectMapper
import com.fasterxml.jackson.module.kotlin.readValue
import kotlinx.android.synthetic.main.activity_perfil.*
import kotlinx.android.synthetic.main.activity_search.*
import kotlinx.android.synthetic.main.player_item.*


private val adapter = PlayerGamerAdapter()

class SearchActivity : AppCompatActivity()/*, CardStackListener*/ {
    private var locationManager : LocationManager? = null
    private var playerId: String? = null
    private var gameId: String? = null
    private var context: AppCompatActivity? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_search)
        playerId = intent.getStringExtra("playerId")
        gameId = intent.getStringExtra("gameId")
        context = this

        ActivityCompat.requestPermissions(this, arrayOf<String>(Manifest.permission.ACCESS_FINE_LOCATION), 1);
        ActivityCompat.requestPermissions(this,arrayOf<String>( Manifest.permission.ACCESS_COARSE_LOCATION), 1);

        locationManager = getSystemService(LOCATION_SERVICE) as LocationManager?

        try {
            locationManager?.requestLocationUpdates(LocationManager.GPS_PROVIDER, 1L, 0f, locationListener)
        } catch(ex: SecurityException) {
            Log.d("myTag", "Security Exception, no location available")
        }

        player_list.setOnItemClickListener {  parent, view, position, id ->
            Toast.makeText(this@SearchActivity, "Solicitação enviada com sucesso!", Toast.LENGTH_SHORT).show()
        }
    }

    private val locationListener: LocationListener = object : LocationListener {
        override fun onLocationChanged(location: Location) {
            PlayerGameRepository().getAll(playerId as String, gameId as String, 100.0, LocationValueObject(location.latitude, location.longitude))
                .responseString { request, response, result ->
                    when(result){
                        is com.github.kittinunf.result.Result.Success -> {
                            val mapper = jacksonObjectMapper().configure(DeserializationFeature.FAIL_ON_UNKNOWN_PROPERTIES, false)
                            val playerGamesResult = mapper.readValue<RequestResult<List<PlayerGame>>>(result.value)

                            player_list.adapter = PlayerAdapter(context!!, R.layout.player_item, playerGamesResult.Result)
                        }
                        is com.github.kittinunf.result.Result.Failure -> {
                            Log.d("myTag", "Security Exception, no location available")
                        }
                    }
                }

        }
        override fun onStatusChanged(provider: String, status: Int, extras: Bundle) {}
        override fun onProviderEnabled(provider: String) {}
        override fun onProviderDisabled(provider: String) {}
    }

    public fun match() {

    }

}
