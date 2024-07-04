﻿namespace ServerManagement.Models
{
    public class Server
    {

        public Server()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            IsOnline = randomNumber == 0 ? false : true;
        }
        public int ServerId { get; set; }
        public bool IsOnline { get; set; }
        public string? ServerName { get; set; }
        public string? ServerLocation { get; set; }
        public DateTime ServerCreationDate { get; set; }

    }
}
