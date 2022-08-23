using AutoMapper;
using BiletAll.WebService.Dto.Response;
using BiletAll.WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletAll.WebService.AutoMapper.Profiles {
  public class SeferlerProfile:Profile {
    public SeferlerProfile() {
      CreateMap<OTipOzellik, OtobusOzellik>().ReverseMap();
      CreateMap<Sefer, SeferlerDTO>().ReverseMap();
    }
  }
}
