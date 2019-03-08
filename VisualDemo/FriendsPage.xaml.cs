using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Linq;

namespace VisualDemo
{
    public partial class FriendsPage : ContentPage
    {
        public FriendsPage()
        {
            InitializeComponent();

            var friends = new List<Friend>()
            {
                new Friend()
                {
                    Photo = "https://pbs.twimg.com/profile_images/1074689633143934983/bptJ7JED_400x400.jpg",
                    Name = "Daniel Hindrikes"
                },
                new Friend()
                {
                    Photo = "https://sec.ch9.ms/ch9/2976/ed4687b6-f18d-43e5-bfd9-b5c8918e2976/XamarinFutureOfAppDevelopment_Custom.jpg",
                    Name = "James Montemagno"
                },
                new Friend()
                {
                    Photo = "https://pbs.twimg.com/profile_images/812310411647205376/gxleSqEg_400x400.jpg",
                    Name = "David Ortinau"
                },
                new Friend()
                {
                    Photo = "https://cdn.cultofmac.com/wp-content/uploads/2013/03/tt2_miguel_de_icaza_keynote.jpg",
                    Name = "Miguel de Icaza"
                }
            };

            FriendList.ItemsSource = friends.OrderBy(x => x.Name);
        }
    }
}
