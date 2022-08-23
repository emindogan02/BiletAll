using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletAll.WebService.Dto.Response {
  public class SeferlerResponseDTO {
    public List<SeferlerDTO>? Seferler { get; set; }
    public List<OtobusOzellik>? OtobusOzellikler { get; set; }
  }
}
