using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Common.Interfaces;
using Common.Model;
using BLLLayer;
using AggregationEngine;
using Autofac.Integration.Mvc;
using AnalysisEngine;

namespace AutofacContainer
{
    public class AutofacContainer
    {
        public ContainerBuilder _container; 
        private AutofacContainer()
        {

        }
        public AutofacContainer(ContainerBuilder container)
        {
            _container = container;
        }
        public void RegisterTypes()
        {
            _container.RegisterType<ApplicationLogic>().As<IApplicationLogic>();
            _container.RegisterType<AggregationEngine.AggregationEngine>().As<IAggregationEngine>();
            _container.RegisterType<AnalysisEngine.Sentiment140AnalysisEngine>().As<IAnalysisEngine>();
        }
        
        
    }
}