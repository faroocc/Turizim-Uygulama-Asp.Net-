using System.Collections.Generic;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstarct
{
    public interface IRezervationService: IGenericService<Rezervation>
    {
          List<Rezervation> TGetListWithActive(int id);
          List<Rezervation> TGetListWithWaitApporoval(int id);
          List<Rezervation> TGetListWithPreviousApporoval(int id);
          List<Rezervation> TGetListWithAcceptedApporoval(int id);

    }
}