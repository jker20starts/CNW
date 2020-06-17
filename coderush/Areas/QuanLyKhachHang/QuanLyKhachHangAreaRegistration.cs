using System.Web.Mvc;

namespace coderush.Areas.QuanLyKhachHang
{
    public class QuanLyKhachHangAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "QuanLyKhachHang";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "QuanLyKhachHang_default",
                "QuanLyKhachHang/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}