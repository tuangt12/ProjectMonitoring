using Serenity.Navigation;
using MyPages = ProjectMonitoring.ProjectMonitoring.Pages;

[assembly: NavigationLink(int.MaxValue, "ProjectMonitoring/Posts", typeof(MyPages.PostsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "ProjectMonitoring/Classes", typeof(MyPages.ClassesController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "ProjectMonitoring/SCMs", typeof(MyPages.SCMsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "ProjectMonitoring/SCMTypes", typeof(MyPages.SCMTypesController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "ProjectMonitoring/Subjects", typeof(MyPages.SubjectsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "ProjectMonitoring/User", typeof(MyPages.UserController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "ProjectMonitoring/User Classes", typeof(MyPages.UserClassesController), icon: null)]