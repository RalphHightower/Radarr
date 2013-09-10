using System;
using System.Collections.Generic;
using System.Linq;
using NLog;
using NzbDrone.Common.Messaging;
using NzbDrone.Core.DecisionEngine.Specifications;
using NzbDrone.Core.Tv.Events;

namespace NzbDrone.Core.Tv
{
    public interface ISeasonService
    {
//        void SetMonitored(int seriesId, int seasonNumber, bool monitored);
//        List<Season> SetSeasonPass(int seriesId, int seasonNumber);
        List<Season> GetSeasonsBySeries(int seriesId);
        List<Season> GetAllSeasons();
    }

    public class SeasonService : ISeasonService
    {
        private readonly ISeasonRepository _seasonRepository;
        private readonly IEpisodeService _episodeService;
        private readonly Logger _logger;

        public SeasonService(ISeasonRepository seasonRepository, IEpisodeService episodeService, Logger logger)
        {
            _seasonRepository = seasonRepository;
            _episodeService = episodeService;
            _logger = logger;
        }

//        public void SetMonitored(int seriesId, int seasonNumber, bool monitored)
//        {
//            var season = _seasonRepository.Get(seriesId, seasonNumber);
//
//            _logger.Trace("Setting monitored flag on Series:{0} Season:{1} to {2}", seriesId, seasonNumber, monitored);
//
//            season.Monitored = monitored;
//            _episodeService.SetEpisodeMonitoredBySeason(seriesId, seasonNumber, monitored);
//            _seasonRepository.Update(season);
//
//            _logger.Info("Monitored flag for Series:{0} Season:{1} successfully set to {2}", seriesId, seasonNumber, monitored);
//        }
//
//        public List<Season> SetSeasonPass(int seriesId, int seasonNumber)
//        {
//            _logger.Trace("Setting up Season Pass for {0} starting with season: {0}", seriesId, seasonNumber);
//            
//            var seasons = GetSeasonsBySeries(seriesId);
//
//            foreach (var season in seasons)
//            {
//                if (season.SeasonNumber >= seasonNumber)
//                {
//                    _logger.Trace("Setting monitored flag on Series:{0} Season:{1} to {2}", seriesId, seasonNumber, true);
//                    season.Monitored = true;
//                    _episodeService.SetEpisodeMonitoredBySeason(seriesId, season.SeasonNumber, true);
//                }
//
//                else
//                {
//                    _logger.Trace("Setting monitored flag on Series:{0} Season:{1} to {2}", seriesId, seasonNumber, false);
//                    season.Monitored = false;
//                    _episodeService.SetEpisodeMonitoredBySeason(seriesId, season.SeasonNumber, false);
//                }
//            }
//
//            _seasonRepository.UpdateMany(seasons);
//            _logger.Trace("Season Pass set for {0} starting with season: {0}", seriesId, seasonNumber);
//
//            return seasons;
//        }

        public List<Season> GetSeasonsBySeries(int seriesId)
        {
            return _seasonRepository.GetSeasonBySeries(seriesId);
        }

        public List<Season> GetAllSeasons()
        {
            return _seasonRepository.All().SelectMany(s => s.Seasons).ToList();
        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      