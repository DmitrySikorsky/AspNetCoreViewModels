// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using AspNetCoreViewModels.Models;

namespace AspNetCoreViewModels.DataAccess
{
  public interface IEventRepository
  {
    IEnumerable<Event> FilteredByDate(DateTime date);
  }
}