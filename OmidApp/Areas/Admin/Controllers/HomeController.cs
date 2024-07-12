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
   
    

    
    

}


