﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Catalog.Model;

namespace Catalog.Wpf
{
    public class SelectedDevelopersComparer : IComparer
    {
        private readonly Func<IEnumerable<Developer>> selectedDevelopersGetter;

        public SelectedDevelopersComparer(Func<IEnumerable<Developer>> selectedDevelopersGetter)
        {
            this.selectedDevelopersGetter = selectedDevelopersGetter;
        }

        public int Compare(object x, object y)
        {
            if (!(x is Developer developerX))
            {
                return -1;
            }

            if (!(y is Developer developerY))
            {
                return 1;
            }

            var selectedDevelopers = selectedDevelopersGetter.Invoke().ToList();

            var selectedX = selectedDevelopers.Contains(developerX);
            var selectedY = selectedDevelopers.Contains(developerY);

            if (selectedX != selectedY)
            {
                return selectedX.CompareTo(selectedY);
            }

            return string.Compare(developerX.Name, developerY.Name, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}