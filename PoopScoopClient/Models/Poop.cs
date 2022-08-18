using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PoopScoopClient.Models
{
   public class Poop
  {
    public int PoopId { get; set; }
    public string Consistency { get; set; }
    public string Volume { get; set; }
    public string Color { get; set; }
    public string Content { get; set; }
    public string Coating { get; set; }
    public string Grade { get; set; }
    public string Problem { get; set; }
    public string Solution { get; set; }

    public static List<Poop> GetPoops()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Poop> poopList = JsonConvert.DeserializeObject<List<Poop>>(jsonResponse.ToString());

      return poopList;
    }

    public static List<Poop> GetColor(string color)
    {
      var apiCallTask = ApiHelper.GetColor(color);
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Poop> poopList = JsonConvert.DeserializeObject<List<Poop>>(jsonResponse.ToString());

      return poopList;
    }

    public static Poop GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Poop poop = JsonConvert.DeserializeObject<Poop>(jsonResponse.ToString());

      return poop;
    }


    public static void Post(Poop poop)
    {
      string jsonPoop = JsonConvert.SerializeObject(poop);
      var apiCallTask = ApiHelper.Post(jsonPoop);
    }

    public static void Put(Poop poop)
    {
      string jsonPoop = JsonConvert.SerializeObject(poop);
      var apiCallTask = ApiHelper.Put(poop.PoopId, jsonPoop);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }
  }
}