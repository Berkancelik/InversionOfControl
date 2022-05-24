using System;

namespace IOC.Web.Models
{
    public interface IDateService
    {

        DateTime GetDateTime { get; }
    }


    interface ISingletonDateService: IDateService { }
    interface IScopedDateService:IDateService { }
    interface ITransitDateService:IDateService { }
}
