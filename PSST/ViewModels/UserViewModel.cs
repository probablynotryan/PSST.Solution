using System.Collections.Generic;

using Treats.Models;

namespace Treats.ViewModels
  {
    public class UserViewModel
    {
      public string UserId { get; init; }
      public List<Flavor> Flavors { get; init; }
      public List<Sweet> Sweets { get; init; }
    }
  }