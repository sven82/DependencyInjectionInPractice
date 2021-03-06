﻿using DIPractice.Common.Weapons;
using System;

namespace DIPractice.Weapons
{
    public class PiercedWeaponAction : IWeaponAction
    {
        #region Methods

        /// <summary>
        /// Gets the weapon action.
        /// </summary>
        /// <returns>Action to perform.</returns>
        public string GetAction()
        {
            return "Pierced";
        }

        #endregion Methods
    }
}