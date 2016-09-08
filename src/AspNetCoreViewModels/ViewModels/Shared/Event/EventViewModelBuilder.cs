// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using AspNetCoreViewModels.DataAccess;
using AspNetCoreViewModels.Models;

namespace AspNetCoreViewModels.ViewModels.Shared
{
  public class EventViewModelBuilder : ViewModelBuilderBase
  {
    public EventViewModelBuilder(IStorage storage) : base(storage)
    {
    }

    public EventViewModel Build(Event @event)
    {
      return new EventViewModel()
      {
        Date = @event.Date,
        Name = @event.Name
      };
    }
  }
}