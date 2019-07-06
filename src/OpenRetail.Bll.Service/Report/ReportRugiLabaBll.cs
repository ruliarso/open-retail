﻿/**
 * Copyright (C) 2017 Kamarudin (http://coding4ever.net/)
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not
 * use this file except in compliance with the License. You may obtain a copy of
 * the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 *
 * The latest version of this file can be found at https://github.com/rudi-krsoftware/open-retail
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using log4net;
using OpenRetail.Model;
using OpenRetail.Model.Report;
using OpenRetail.Bll.Api.Report;
using OpenRetail.Repository.Api;
using OpenRetail.Repository.Service;
using OpenRetail.Helper;

namespace OpenRetail.Bll.Service.Report
{
    public class ReportRugiLabaBll : IReportRugiLabaBll
    {
        private ILog _log;
        private IUnitOfWork _unitOfWork;

        public ReportRugiLabaBll(ILog log)
        {
            _log = log;
        }

        public ReportRugiLaba GetByBulan(int bulan, int tahun)
        {
            ReportRugiLaba obj = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                obj = _unitOfWork.ReportRugiLabaRepository.GetByBulan(bulan, tahun);
            }

            return obj;
        }

        public ReportRugiLaba GetByTanggal(DateTime tanggalMulai, DateTime tanggalSelesai)
        {
            ReportRugiLaba obj = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                obj = _unitOfWork.ReportRugiLabaRepository.GetByTanggal(tanggalMulai, tanggalSelesai);
            }

            return obj;
        }
    }
}
