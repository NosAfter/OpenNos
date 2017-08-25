﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenNos.GameObject.Helpers
{
    public class MateHelper
    {
        public MateHelper()
        {
            LoadXpData();
        }

        private static double[] _xpData { get; set; }

        public static double[] XPData
        {
            get
            {
                if (_xpData == null)
                {
                    new MateHelper();
                }
                return _xpData;
            }
        }

        public static void LoadXpData()
        {
            // Load XpData
            _xpData = new double[256];
            double[] v = new double[256];
            double var = 1;
            v[0] = 540;
            v[1] = 960;
            _xpData[0] = 300;
            for (int i = 2; i < v.Length; i++)
            {
                v[i] = v[i - 1] + 420 + 120 * (i - 1);
            }
            for (int i = 1; i < _xpData.Length; i++)
            {
                if (i < 79)
                {
                    if (i == 14)
                    {
                        var = 6 / 3d;
                    }
                    else if (i == 39)
                    {
                        var = 19 / 3d;
                    }
                    else if (i == 59)
                    {
                        var = 70 / 3d;
                    }
                    _xpData[i] = Convert.ToInt64(_xpData[i - 1] + var * v[i - 1]);
                }
                if (i >= 79)
                {
                    if (i == 79)
                    {
                        var = 5000;
                    }
                    if (i == 82)
                    {
                        var = 9000;
                    }
                    if (i == 84)
                    {
                        var = 13000;
                    }
                    _xpData[i] = Convert.ToInt64(_xpData[i - 1] + var * (i + 2) * (i + 2));
                }

                // Console.WriteLine($"LvL {i}: xpdata: {_xpData[i - 1]} v: {v[i - 1]}");
            }
        }
    }
}