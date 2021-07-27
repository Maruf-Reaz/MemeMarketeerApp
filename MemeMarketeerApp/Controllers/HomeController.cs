using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MemeMarketeerApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using MemeMarketeerApp.Models.Common.Authentication;
using MemeMarketeerApp.Data;
using MemeMarketeerApp.Models.ViewModels;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MemeMarketeerApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }

        //[Authorize(Roles = "GateAdmin, HarbourAndMarine, Mechanical, Admin, TMOffice")]
        public async Task<IActionResult> Index()
        {
            DateTime fromDate = DateTime.Now.AddDays(-30);
            DateTime toDate = DateTime.Now;


            //var user = (await _userManager.FindByNameAsync(HttpContext.User.Identity.Name)); //same thing
            //if (await _userManager.IsInRoleAsync(user, "Admin"))
            //{
            //    ViewData["Merchants"] = await _context.Merchants.Include(m => m.ApplicationUser).Where(m => m.ApplicationUser.Status == 1).ToListAsync();
            //     ViewData["DeliveryMans"] = await _context.DeliveryMans.Where(m => m.Status == 1).ToListAsync();
            //    ViewData["IsAdmin"] = true;


            //}
            //else if (await _userManager.IsInRoleAsync(user, "Merchant"))
            //{
            //    ViewData["Tarrifs"] = await _context.Tarrifs.Include(m => m.PackageCatagory).Include(m => m.LocationFrom).Include(m => m.LocationTo).Where(m => m.Status == 1).ToListAsync();
            //    ViewData["IsAdmin"] = false;
            //}
            ViewData["Affiliates"] = await _context.Affiliates.OrderByDescending(m => m.Id).Take(10)
                    .Include(m => m.AffiliateLanguage)
                    .Include(m => m.Catagory).ToListAsync();
            ViewData["AffiliateCount"] = await _context.Affiliates.CountAsync();
            ViewData["AffiliateCountThisMonth"] = await _context.Affiliates.Where(m => m.AddintionDate <= toDate && m.AddintionDate >= fromDate).CountAsync();


            ViewData["Clients"] = await _context.Clients.OrderByDescending(m => m.Id).Take(10).ToListAsync();
            ViewData["ClientCount"] = await _context.Clients.CountAsync();
            ViewData["ClientCountThisMonth"] = await _context.Clients.Where(m => m.AddintionDate <= toDate && m.AddintionDate >= fromDate).CountAsync();


            ViewData["CampaignCount"] = await _context.Campaigns.CountAsync();
            ViewData["CampaignCountThisMonth"] = await _context.Campaigns.Where(m => m.CreationDate <= toDate && m.CreationDate >= fromDate).CountAsync();
            var allcampaigns = await _context.Campaigns.Include(m => m.Client).OrderByDescending(m => m.Id).Take(10).ToListAsync();
            List<CampaignHomeViewModel> campaigns = new List<CampaignHomeViewModel>();

            foreach (var soloCampaign in allcampaigns)
            {
                CampaignHomeViewModel campaign = new CampaignHomeViewModel();
                campaign.Campaign = soloCampaign;
                if (soloCampaign.Status == 1)
                {
                    campaign.TotalExpence = Campaign.GetExpenseForCampaign(soloCampaign.Id, _context);
                    campaign.TotalImpressionGenerated = Campaign.GetImpressionsGenerated(soloCampaign.Id, _context);

                }

                campaigns.Add(campaign);
            }

            ViewData["Campaigns"] = campaigns;




            ViewData["ImpressionCount"] = await _context.Posts.Where(m => m.Campaign.Status == 1).SumAsync(m => m.ImpressionGenerated);
            ViewData["ImpressionCountThisMonth"] = await _context.Posts.Where(m => m.Campaign.CreationDate <= toDate && m.Campaign.CreationDate >= fromDate && m.Campaign.Status == 1).SumAsync(m => m.ImpressionGenerated);


            ViewData["LinkClickCount"] = await _context.Campaigns.Where(m => m.Status == 1).SumAsync(m => m.TotalLinkClicked);
            ViewData["LinkClickCountThisMonth"] = await _context.Campaigns.Where(m => m.CreationDate <= toDate && m.CreationDate >= fromDate && m.Status == 1).SumAsync(m => m.TotalLinkClicked);


            ViewData["FollowersGeneratedCount"] = await _context.Campaigns.Where(m => m.Status == 1).SumAsync(m => m.TotalFollowerIncreament);
            ViewData["FollowersGeneratedCountThisMonth"] = await _context.Campaigns.Where(m => m.CreationDate <= toDate && m.CreationDate >= fromDate && m.Status == 1).SumAsync(m => m.TotalFollowerIncreament);



            ViewData["NetworkReach"] = await _context.Posts.Where(m => m.Campaign.Status == 1).SumAsync(m => m.ImpressionGenerated);
            ViewData["ImpressionCountThisMonth"] = await _context.Posts.Where(m => m.Campaign.CreationDate <= toDate && m.Campaign.CreationDate >= fromDate && m.Campaign.Status == 1).SumAsync(m => m.ImpressionGenerated);

            double expenseTotal = _context.Posts.Where(m => m.Campaign.Status == 1).Sum(m => m.PaidAmount);
            expenseTotal += _context.Expenses.Sum(m => m.Amount);


            var totalAffiliates = _context.Affiliates.Where(m => m.Status == 1)
                  .Include(m => m.AffiliateLanguage).ToList();

            double totalPostReachCap = 0;
            double totalStoryViewCap = 0;

            foreach (var aff in totalAffiliates)
            {
                var totalPosts = _context.Posts.OrderByDescending(m => m.Id).Where(m => m.AffiliateId == aff.Id && m.Campaign.Status == 1 && ((m.PostTypeId == 1 && m.ImpressionGenerated != 0) || (m.PostTypeId == 3 && m.PostReached != 0))).ToList();

                int postCount = 0;
                double  postReached = 0;
                foreach (var post in totalPosts)
                {
                    if (post.PostTypeId==1)
                    {
                        postCount++;
                        postReached += post.ImpressionGenerated;
                    }
                    else if (post.PostTypeId == 3)
                    {
                        postCount++;
                        postReached += post.PostReached;
                    }
                }



                var totalStories = _context.Posts.OrderByDescending(m => m.Id).Where(m => m.AffiliateId == aff.Id && m.Campaign.Status == 1 && ((m.PostTypeId == 2 && m.ImpressionGenerated != 0) || (m.PostTypeId == 3 && m.StoryViewed != 0))).ToList();


                int storyCount = 0;
                double storyVIewed = 0;
                foreach (var story in totalStories)
                {
                    if (story.PostTypeId == 2)
                    {
                        storyCount++;
                        storyVIewed += story.ImpressionGenerated;
                    }
                    else if (story.PostTypeId == 3)
                    {
                        storyCount++;
                        storyVIewed += story.StoryViewed;
                    }
                }




                if (postCount != 0 && postReached != 0)
                {
                    totalPostReachCap += postReached / postCount;
                }
                if (storyCount != 0 && storyVIewed != 0)
                {
                    totalStoryViewCap += storyVIewed / storyCount;
                }


            }








            ViewData["TotalNetworkReach"] = totalPostReachCap+ totalStoryViewCap;
            ViewData["TotalExpence"] = expenseTotal;



            ViewData["TotalIncome"] = await _context.Campaigns.Where(m => m.Status == 1).SumAsync(m => m.TotalBudget);



            return View();
        }

        public IActionResult AssignmentData(DateTime getDate, DateTime fromDate)
        {
            if (fromDate == default(DateTime))
            {
                fromDate = DateTime.Now.Date;
            }

            ViewData["Date"] = fromDate.Date;
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
