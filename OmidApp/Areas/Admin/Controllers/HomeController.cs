using System.Net.Http.Headers;
using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OmidApp.Models;
using Extensions;

[Area("Admin")]
public class HomeController : Controller
{

   private readonly IUser dbUser;
   
   private readonly IWalet dbWalet;
   private readonly Context _context;

    public HomeController(IUser _dbUser,IWalet _dbWalet ,Context _context)
    {
        
        dbUser = _dbUser;
        dbWalet = _dbWalet;
        this._context = _context;
    }
    
 

  public IActionResult Index(string txt)
    {
      //search
     
         ViewBag.User=dbUser.ShowAllUser(txt);
      
       
      

        return View();
    }
     public IActionResult login()
    {
        return View();
    }
     public IActionResult log(int Password, string email)
    {
        if (Password == 1234 && email == "admin")
        {
               var claims = new List<Claim>() 
               {
               new Claim (ClaimTypes.NameIdentifier,"admin"),
               new Claim (ClaimTypes.Name, "admin")
               };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);

                var properties = new AuthenticationProperties
                {
                    ExpiresUtc = DateTime.UtcNow.AddYears(1),
                    IsPersistent = true
                };
                HttpContext.SignInAsync(principal, properties);
                return RedirectToAction("index");
        }
        else
        {
            
             TempData["error"] = "Error";
             return RedirectToAction("login");
        }
    }
    public async Task<IActionResult> ParticipantsscoreAsync(string txt)
    {
        
      try
      {
         DateTime Today=txt.ToGeorgianDateTime();
      
         return View();
      }
      catch (System.Exception ex)
      {
         
         return View();
      }
     
    
     
    }
    public IActionResult info(string txt)
    {
       ViewBag.User=dbUser.ShowAllUser(txt);
      return View();
    }
   
    public IActionResult paystatus(string txt)
    {
      //TODO: Implement Realistic Implementation
       try
      {
         DateTime Today=txt.ToGeorgianDateTime();
         ViewBag.walet=dbWalet.ShowResultAll().Where(x=>x.date.Date==Today).OrderByDescending(x=>x.Id).ToList();
         ViewBag.Mojodi=dbWalet.ShowResultAll().Where(x=>x.date.Date==Today).Sum(x=>x.variz);
         
      }
      catch (System.Exception ex)
      {
         
           ViewBag.walet=dbWalet.ShowResultAll().OrderByDescending(x=>x.Id).ToList();
           ViewBag.Mojodi=dbWalet.ShowResultAll().Sum(x=>x.variz);
      }
      
       
             
         return View();
    }
    public IActionResult setting()
    {
      //TODO: Implement Realistic Implementation

      return View();
    }
    public IActionResult bag()
    {
      //TODO: Implement Realistic Implementation
      return View();
    }

    public IActionResult logout()
    {
        HttpContext.SignOutAsync();
        return RedirectToAction("login");
    }
    
    //agent 
    public IActionResult agentinfo(int id)
    {
      var q=dbUser.ChangeAgent(id);
      return RedirectToAction("index");
    }

    public IActionResult walet(string phone )
    {
        ViewBag.walet=dbWalet.ShowAllWalet(phone);
        //nameresives take 1 into viewbag.walet
        ViewBag.name=dbUser.ShowAllUser(phone).FirstOrDefault().FirstAndLastName + "  با شماره تلفن : " +phone ;
        ViewBag.tel=phone;
        ViewBag.mojodi=dbWalet.ShowMojodi(phone);
        //save phone to session
        if (phone != null)
        HttpContext.Session.SetString("phone",phone);
        return View();
    }
    
    public IActionResult charge(int txt)
    {
        dbWalet.ChargeAccunt(txt,HttpContext.Session.GetString("phone"));
        return RedirectToAction("walet",new {phone=HttpContext.Session.GetString("phone")});
    }
    

    public IActionResult del(int id)
    {
        // TODO: Your code here
          dbWalet.delete(id);
       return RedirectToAction("walet",new {phone=HttpContext.Session.GetString("phone")});
    }
    
    public async Task<IActionResult> deatilsAsync(int id)
    {
       
          
      
       
           return View();
    }

    public IActionResult agent(string txt)
    {
        // TODO: Your code here
         ViewBag.User=dbUser.ShowAllUseragent(txt);

        return View();
    }

    public IActionResult waletall()
    {
        // TODO: Your code here
        
        return View();
    }
    

    

    public IActionResult exit()
    {
        // TODO: Your code here
        HttpContext.SignOutAsync();
        return RedirectToAction("login");
       
    }
    

    
    

    //vige
    public IActionResult vige(int id)
    {
      var user=_context.Users.Find(id);
      if (user.Url=="vige")
      {
        user.Url="";
      }else
      {
        //first delete all vige
        var q=_context.Users.Where(x=>x.Url=="vige").ToList();
        if (q.Count() < 4)
        {
           user.Url="vige";
           
        }else
        { 
          TempData["msg"]="بیش از 4 نفر امکان ویژه بودن را ندارند ";
        }
        

       
      }
      

            _context.Users.Update(user);
             _context.SaveChanges();

      
      return RedirectToAction("index");
      
    }
    


    // category
    public IActionResult category()
    {

      //check if Categories is empty add default category parent "خودروهای سبک" و"خودروهای سنگین" "سایر"
      if (_context.Categories.Count()==0)
      {
        _context.Categories.Add(new Category{CatName="خودروهای سبک",ParentId=0,Status="فعال"});
        _context.Categories.Add(new Category{CatName="خودروهای سنگین",ParentId=0,Status="فعال"});
        _context.Categories.Add(new Category{CatName="سایر",ParentId=0,Status="فعال"});
        _context.SaveChanges();
      }
      ViewBag.Category=_context.Categories.Where(x=>x.ParentId==0).ToList();

       return View();


    }


    //add category
    public IActionResult addcar(string CatName)
    {
      string msg="";

      //check exist category
      var q=_context.Categories.Where(x=>x.CatName==CatName).FirstOrDefault();
      if (q==null)
      {

        //get session id

        //get session id
        int ParentId=HttpContext.Session.GetInt32("id").Value;

        
        _context.Categories.Add(new Category{CatName=CatName,ParentId=ParentId,Status="فعال"});
        _context.SaveChanges();
        msg="دسته بندی با موفقیت ثبت شد";
      }else
      {
        msg="این دسته بندی قبلا ثبت شده است";
      }

            // writed by mhd
      //add a fild to price table with  carId 
      //find carId by CatName
      var find=_context.Categories.Where(x=>x.CatName==CatName).FirstOrDefault();
          _context.Prices.Add(new Price{carId=find.Id});
          _context.SaveChanges();


      //get id by session
      return RedirectToAction("car",new{id=HttpContext.Session.GetInt32("id"),meesage=msg});

      
    }


    public IActionResult Car(int id ,string? meesage)
    {
      //add session id
      HttpContext.Session.SetInt32("id",id);
      //viewbad listcars
      ViewBag.listcars=_context.Categories.Where(x=>x.ParentId==id).ToList();
      //viewbad catname
      ViewBag.catname=_context.Categories.Find(id).CatName;
      //viewbad id
      ViewBag.id=id;
      //viewbad meesage
      ViewBag.meesage=meesage;
      return View();
    }

    public IActionResult Service(int id)
    {
 

              ViewBag.catname=_context.Categories.Find(id).CatName;

      // find row with carId == id
      var find=_context.Prices.Where(x=>x.carId==id).FirstOrDefault();
      Price price = new Price();
      price.carId=id;
      if(find != null)
      {
      price.motorKamel = find.motorKamel;
      price.blokSilandr = find.blokSilandr;
      price.silandr = find.silandr;
      price.sarSilandr = find.sarSilandr;
      price.boshSilandr = find.boshSilandr;
      price.waterPump = find.waterPump;
      price.pichKarter = find.pichKarter;
      price.karter = find.karter;
      price.millang = find.millang;
      price.ringPiston = find.ringPiston;
      price.piston = find.piston;
      price.fanarSopap = find.fanarSopap;
      price.shaton = find.shaton;
      price.flayol = find.flayol;
      price.milSopap = find.milSopap;
      price.sopap = find.sopap;
      price.sopapPVC = find.sopapPVC;
      price.motorStart = find.motorStart;
      price.superCharger = find.superCharger;
      price.turboCharger = find.turboCharger;
      price.pumproghan = find.pumproghan;
      price.manifold = find.manifold;
      price.headers = find.headers;
      price.hydrolic = find.hydrolic;
      price.compersorColer = find.compersorColer;
      price.jabeFarman = find.jabeFarman;
      price.radiator = find.radiator;
      price.carbirator = find.carbirator;
      price.ring = find.ring;
      price.sagDast = find.sagDast;
      price.kaseCharkh = find.kaseCharkh;
      price.fanar = find.fanar;
      price.komakfanar = find.komakfanar;
      price.plasticMotor = find.plasticMotor;
      price.sayerMotor = find.sayerMotor;
      price.sayerZir = find.sayerZir;
      price.gearboxAuto = find.gearboxAuto;
      price.gearboxManual = find.gearboxManual;
      price.safeCluch = find.safeCluch;
      price.milMahak = find.milMahak;
      price.keshoie = find.keshoie;
      price.shafetVorodi = find.shafetVorodi;
      price.shafetKharoji = find.shafetKharoji;
      price.charkhDande = find.charkhDande;
      price.bolboring = find.bolboring;
      price.hozing = find.hozing;
      price.milGarden = find.milGarden;


      }

      else if(find == null)
      {
        _context.Prices.Add(price);
        _context.SaveChanges();
      }
      return View(price);
      
    }
   
    
    // update price
    [HttpPost]
    public IActionResult ServiceUpdate(Price price)
    {
      var find=_context.Prices.Where(x=>x.carId==price.carId).FirstOrDefault();
      if(find != null)
      {
      find.carId = price.carId;
      find.motorKamel = price.motorKamel;
      find.blokSilandr = price.blokSilandr;
      find.silandr = price.silandr;
      find.sarSilandr = price.sarSilandr;
      find.boshSilandr = price.boshSilandr;
      find.waterPump = price.waterPump;
      find.pichKarter = price.pichKarter;
      find.karter = price.karter;
      find.millang = price.millang;
      find.ringPiston = price.ringPiston;
      find.piston = price.piston;
      find.fanarSopap = price.fanarSopap;
      find.shaton = price.shaton;
      find.flayol = price.flayol;
      find.milSopap = price.milSopap;
      find.sopap = price.sopap;
      find.sopapPVC = price.sopapPVC;
      find.motorStart = price.motorStart;
      find.superCharger = price.superCharger;
      find.turboCharger = price.turboCharger;
      find.pumproghan = price.pumproghan;
      find.manifold = price.manifold;
      find.headers = price.headers;
      find.hydrolic = price.hydrolic;
      find.compersorColer = price.compersorColer;
      find.jabeFarman = price.jabeFarman;
      find.radiator = price.radiator;
      find.carbirator = price.carbirator;
      find.ring = price.ring;
      find.sagDast = price.sagDast;
      find.kaseCharkh = price.kaseCharkh;
      find.fanar = price.fanar;
      find.komakfanar = price.komakfanar;
      find.plasticMotor = price.plasticMotor;
      find.sayerMotor = price.sayerMotor;
      find.sayerZir = price.sayerZir;
      find.gearboxAuto = price.gearboxAuto;
      find.gearboxManual = price.gearboxManual;
      find.safeCluch = price.safeCluch;
      find.milMahak = price.milMahak;
      find.keshoie = price.keshoie;
      find.shafetVorodi = price.shafetVorodi;
      find.shafetKharoji = price.shafetKharoji;
      find.charkhDande = price.charkhDande;
      find.bolboring = price.bolboring;
      find.hozing = price.hozing;
      find.milGarden = price.milGarden;
      _context.Prices.Update(find);
      _context.SaveChanges();
      }
      return RedirectToAction("Service",new{id=price.carId});
    }
      

    
    

}


