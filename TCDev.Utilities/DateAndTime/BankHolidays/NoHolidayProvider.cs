﻿using TCDev.Utilities.DateAndTime.BankHolidays.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCDev.Utilities.DateAndTime.BankHolidays
{
    /// <summary>
    /// NoHolidaysProvider
    /// </summary>
    internal class NoHolidaysProvider : IPublicHolidayProvider
    {
        private static readonly Lazy<IPublicHolidayProvider> _instance =
            new Lazy<IPublicHolidayProvider>(() => new NoHolidaysProvider());

        /// <summary>
        /// Gets the singleton instance of <see cref="NoHolidaysProvider"/>.
        /// </summary>
        public static IPublicHolidayProvider Instance
        {
            get { return _instance.Value; }
        }

        private NoHolidaysProvider() { }

        ///<inheritdoc/>
        public IEnumerable<PublicHoliday> Get(int year)
        {
            return Enumerable.Empty<PublicHoliday>();
        }

        ///<inheritdoc/>
        public IEnumerable<string> GetSources()
        {
            return Enumerable.Empty<string>();
        }
    }
}