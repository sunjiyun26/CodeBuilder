﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeBuilder.DataSource.Exporter.MySQL
{
    using PhysicalDataModel;

    public class MySqlExporter : BaseExporter, IExporter
    {
        #region IExporter 成员

        public override Model Export(ExportConfig config)
        {
            return null;
        }

        #endregion
    }
}