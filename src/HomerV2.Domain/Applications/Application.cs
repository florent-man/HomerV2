using System;
using System.Collections.Generic;
using HomerV2.Enums;
using Volo.Abp.Domain.Entities;

namespace HomerV2.Applications
{
    public class Application : AggregateRoot<Guid>
    {
        public string Name { get; private set; }
        public string Logo { get; private set; }
        public string Url { get; private set; }
        public string Target { get; private set; }
        public MenuTypes MenuTypes { get; private set; }

        protected Application() { }

        public Application(Guid id, string name, string logo, string url, string target, MenuTypes menuTypes) : base(id)
        {
            Name = name;
            Logo = logo;
            Url = url;
            Target = target;
            MenuTypes = menuTypes;
        }
        
        public void ChangeName(string name)
        {
            Name = name;
        }
        
        //Encode
        public void ChangeLogoFromFile(byte[] imageBytes)
        {
            
            Logo = Convert.ToBase64String(imageBytes);
        }

        //Decode
        public byte[] GetLogoAsByteArray()
        {
        
            return Convert.FromBase64String(Logo);
        }
        
        public void ChangeUrl(string url)
        {
            Url = url;
        }
        
        public void ChangeTarget(string target)
        {
            Target = target;
        }
        
        public void UpdateMenuTypes(MenuTypes menuTypes)
        {
            MenuTypes = menuTypes;
        }
    }
}