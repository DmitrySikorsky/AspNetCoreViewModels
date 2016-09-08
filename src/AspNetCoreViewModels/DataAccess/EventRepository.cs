// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreViewModels.Models;

namespace AspNetCoreViewModels.DataAccess
{
  public class EventRepository : IEventRepository
  {
    private readonly IEnumerable<Event> events = new Event[]
    {
      new Event() { Id = 1, Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 3, 15, 0, 0), Name = "Отдать кота" },
      new Event() { Id = 2, Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 7, 6, 30, 0), Name = "Забрать кота" },
      new Event() { Id = 3, Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 21, 8, 0, 0), Name = "Сделать что-то еще" }
    };

    public IEnumerable<Event> FilteredByDate(DateTime date)
    {
      return this.events.Where(e => e.Date.Date == date.Date);
    }
  }
}