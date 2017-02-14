# redis-session
Redis session for asp.net mvc/api share model

from nuget

Install-Package Microsoft.Web.RedisSessionStateProvider

# Mvc

# shared Model
    public class TestSessionModel
    {
        public int Id { get; set; }
        public string TestName { get; set; }    
    }

 if not put [Serializable] Attribute redis session error
![Image of Yaktocat](https://raw.githubusercontent.com/knodejs/redis-session/785078671f2cce00c0aed49eace24aeb569c6438/RedisSession.Web/Errors/1487067254112.jpg)

# after put [Serializable] Attribute

    [Serializable]
    public class TestSessionModel
    {
        public int Id { get; set; }
        public string TestName { get; set; }    
    }

# test mvc stored session passed

# api
   test valuecontroller return TestSessionModel

Errors

![Image of Yaktocat](https://raw.githubusercontent.com/knodejs/redis-session/90e6e42a9e834f61adab2a7164af6afee37aedb0/RedisSession.Api/Errors/1487067939473.jpg)
not correct format


we can fix by Update WebapiConfig.cs add

    config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new DefaultContractResolver();


Reference

http://stackoverflow.com/questions/20914080/make-json-net-and-serializable-attribute-work-together