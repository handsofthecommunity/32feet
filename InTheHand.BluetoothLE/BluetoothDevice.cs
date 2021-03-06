﻿//-----------------------------------------------------------------------
// <copyright file="BluetoothDevice.cs" company="In The Hand Ltd">
//   Copyright (c) 2018-19 In The Hand Ltd, All rights reserved.
//   This source code is licensed under the MIT License - see License.txt
// </copyright>
//-----------------------------------------------------------------------

using InTheHand.Bluetooth.GenericAttributeProfile;
using System;

namespace InTheHand.Bluetooth
{
    public sealed partial class BluetoothDevice
    {
        public string Id { get { return GetId(); } }
        public string Name { get { return GetName(); } }
        public BluetoothRemoteGATTServer Gatt { get { return GetGatt(); } }

        /*
        public Task WatchAdvertisementsAsync()
        {
            return DoWatchAdvertisements();
        }

        public void UnwatchAdvertisements()
        {
            DoUnwatchAdvertisements();
        }

        public bool WatchingAdvertisements { get { return GetWatchingAdvertisements(); } }

        internal void OnAdvertismentReceived(BluetoothAdvertisingEvent advertisement)
        {
            AdvertisementReceived?.Invoke(this, advertisement);
        }

        public event EventHandler<BluetoothAdvertisingEvent> AdvertisementReceived;
        */

        internal void OnGattServerDisconnected()
        {
            GattServerDisconnected?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Fired when an active GATT connection is lost.
        /// </summary>
        public event EventHandler GattServerDisconnected;
    }
}
