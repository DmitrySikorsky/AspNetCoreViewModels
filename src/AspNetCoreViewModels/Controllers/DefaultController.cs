// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using AspNetCoreViewModels.DataAccess;
using AspNetCoreViewModels.ViewModels.Default.Calendar;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreViewModels.Controllers
{
  public class DefaultController : Controller
  {
    private IStorage storage;

    public DefaultController(IStorage storage)
    {
      this.storage = storage;
    }

    public ActionResult Calendar()
    {
      return this.View(new CalendarViewModelBuilder(this.storage).Build());
    }
  }
}