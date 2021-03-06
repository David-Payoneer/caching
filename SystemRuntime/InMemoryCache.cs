﻿using System;

namespace PubComp.Caching.SystemRuntime
{
    public class InMemoryCache : ObjectCache
    {
        public InMemoryCache(String name, InMemoryPolicy policy)
            : base(name, new System.Runtime.Caching.MemoryCache(name), policy)
        {
        }

        public InMemoryCache(String name, TimeSpan slidingExpiration)
            : this(name,
                new InMemoryPolicy
                {
                    SlidingExpiration = slidingExpiration
                })
        {
        }

        public InMemoryCache(String name, DateTimeOffset absoluteExpiration)
            : this(name,
                new InMemoryPolicy
                {
                    AbsoluteExpiration = absoluteExpiration
                })
        {
        }
    }
}
