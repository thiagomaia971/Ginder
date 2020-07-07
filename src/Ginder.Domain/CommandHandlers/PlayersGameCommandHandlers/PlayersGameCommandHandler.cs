using System;
using System.Linq;
using Ginder.Domain.Commands.PlayersGameCommands;
using Ginder.Domain.Entities;
using Ginder.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
    
namespace Ginder.Domain.CommandHandlers.PlayersGameCommandHandlers
{
    public class PlayersGameCommandHandler : CommandHandler<PlayersGameCommand, IQueryable<PlayerGame>>
    {
        private readonly IPlayerGameRepository _playerGameRepository;

        public PlayersGameCommandHandler(IPlayerGameRepository playerGameRepository) 
            => _playerGameRepository = playerGameRepository;

        public override IQueryable<PlayerGame> Handle(PlayersGameCommand command)
        {
            var includableQueryable = _playerGameRepository.GetAll()
                .Where(x => x.GameId == command.GameId && x.PlayerId != command.PlayerId)
                .Include(x => x.Player)
                .Include(x => x.Game);
            var toCoordinate = new Coordinates(command.Latitude, command.Longitude);
            return includableQueryable
                .ToList()
                .Where(x => new Coordinates(x.Player.Location.Latitude, x.Player.Location.Longitude).DistanceTo(toCoordinate) < command.Distance)
                .AsQueryable();
        }
    }
    
    public class Coordinates
    {
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }

        public Coordinates(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
    public static class CoordinatesDistanceExtensions
    {
        public static double DistanceTo(this Coordinates baseCoordinates, Coordinates targetCoordinates)
        {
            return DistanceTo(baseCoordinates, targetCoordinates, UnitOfLength.Kilometers);
        }

        public static double DistanceTo(this Coordinates baseCoordinates, Coordinates targetCoordinates, UnitOfLength unitOfLength)
        {
            var baseRad = Math.PI * baseCoordinates.Latitude / 180;
            var targetRad = Math.PI * targetCoordinates.Latitude/ 180;
            var theta = baseCoordinates.Longitude - targetCoordinates.Longitude;
            var thetaRad = Math.PI * theta / 180;

            double dist =
                Math.Sin(baseRad) * Math.Sin(targetRad) + Math.Cos(baseRad) *
                Math.Cos(targetRad) * Math.Cos(thetaRad);
            dist = Math.Acos(dist);

            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

            return unitOfLength.ConvertFromMiles(dist);
        }
    }

    public class UnitOfLength
    {
        public static UnitOfLength Kilometers = new UnitOfLength(1.609344);
        public static UnitOfLength NauticalMiles = new UnitOfLength(0.8684);
        public static UnitOfLength Miles = new UnitOfLength(1);

        private readonly double _fromMilesFactor;

        private UnitOfLength(double fromMilesFactor)
        {
            _fromMilesFactor = fromMilesFactor;
        }

        public double ConvertFromMiles(double input)
        {
            return input*_fromMilesFactor;
        }
    } 

}