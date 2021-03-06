﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabularEditor.PropertyGridUI
{
    internal class KPIStatusGraphicConverter: TypeConverter
    {
        public static string[] StatusValues = {
            "Cylinder",
            "Faces",
            "Gauge",
            "Reversed Gauge",
            "Road Signs",
            "Shapes",
            "Thermometer",
            "Traffic Light",
            "Variance arrow"
        };

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string)) return true;

            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            return value;
        }

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return new StandardValuesCollection(StatusValues);
        }
    }
}
