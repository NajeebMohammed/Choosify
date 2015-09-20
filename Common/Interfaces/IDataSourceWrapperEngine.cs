﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;
namespace Common.Interfaces
{
    public interface IDataSourceWrapperEngine
    {
        List<AnalysedMessages> FetchMessages(List<Subject> filter);
        void Initialize();
    }
}
