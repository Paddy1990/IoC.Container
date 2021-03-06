﻿using System;
using System.Collections.Generic;
using IoC.Container.Models;
using Ioc.Container.Constants;

namespace IoC.Container.FluentApi
{
	public class IocLifeCycleBuilder
	{
		private Dictionary<Type, List<ConcreteType>> _registeredTypes;

		public IocLifeCycleBuilder(IocBuilder iocBuilder)
		{
			_registeredTypes = iocBuilder.RegisteredTypes;
		}
//
//		public void AsSingleton()
//		{
//			_concreteType.Options.LifeCycle = LifeCycle.Singleton;
//		}
//
//		public void AsTransient()
//		{
//			_concreteType.Options.LifeCycle = LifeCycle.Transient;
//		}
//
//		public void PerRequest()
//		{
//			_concreteType.Options.LifeCycle = LifeCycle.PerRequest;
//		}
	}
}