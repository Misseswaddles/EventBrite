using Microsoft.EntityFrameworkCore;
using System;


public static class UserSeed
{
    public static void Seed(UserContext context)
    {
        context.Database.Migrate();

       
    }

    private static Permissions[] GetPreConfiguredUserPermissions()
    {
        throw new NotImplementedException();
    }
}
