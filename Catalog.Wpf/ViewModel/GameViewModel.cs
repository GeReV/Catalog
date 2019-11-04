﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Catalog.Model;

namespace Catalog.Wpf.ViewModel
{
    public class GameViewModel : NotifyPropertyChangedBase
    {
        private GameCopy gameCopy;
        private ResettableLazy<IEnumerable<GameItemGroupViewModel>> gameStats;

        public GameViewModel(GameCopy gameCopy)
        {
            GameCopy = gameCopy;

            gameStats = new ResettableLazy<IEnumerable<GameItemGroupViewModel>>(() =>
                GameItemGrouping.GroupItems(GameCopy.Items));
        }

        public GameCopy GameCopy
        {
            get => gameCopy;
            set
            {
                if (Equals(value, gameCopy)) return;
                gameCopy = value;

                gameStats.Reset();

                OnPropertyChanged(null);
            }
        }

        public string Title => GameCopy.Title;

        public Publisher Publisher => GameCopy.Publisher;

        public IList<Developer> Developers => GameCopy.Developers;

        public string Notes => GameCopy.Notes;

        public ImageSource Cover => GameCopy.CoverImage?.Path == null
            ? null
            : new BitmapImage(new Uri(GameCopy.CoverImage.Path));

        public IEnumerable<ScreenshotViewModel> Screenshots =>
            GameCopy.Screenshots.Select(ScreenshotViewModel.FromImage).ToList();

        public IEnumerable<GameItemGroupViewModel> GameStats => gameStats.Value;

        public bool HasBigBox => GameStats.Any(group => group.ItemType.Equals(ItemTypes.BigBox) && !group.Missing);
    }
}