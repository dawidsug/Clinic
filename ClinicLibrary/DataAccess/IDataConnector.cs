﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLibrary.DataAccess
{
    public interface IDataConnector
    {
        void CreateDoctor(DoctorModel model);
        List<DoctorModel> GetDoctors_All();
    }
}
