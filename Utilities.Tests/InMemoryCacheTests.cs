﻿using System;
using Shouldly;
using Xunit;
{
	public class InMemoryCacheTests : IUseFixture<InMemoryCache>
	{
		private InMemoryCache _implementation;
		private readonly object _someValue = new object();
		private string _someKey = "Akey";
		public void SetFixture(InMemoryCache data)
		{
			_implementation = data;
		}
		public void InMemoryCache_SetOrAdd_WhenKeyIsNull_ThenShouldThrowArgumentNullException()
		{
			Should.Throw<ArgumentNullException>(() => _implementation.SetOrAdd(null, _someValue));
		}
		public void InMemoryCache_SetOrAdd_WhenValueIsNull_ThenGetShouldReturnNull()
		{
		}
		[Fact]
		public void InMemoryCache_Get_WhenValueIsNull_And_Requesting_DifferentType_ThenGetShouldReturnNull()
		{
		}
		public void InMemoryCache_Get_WhenValueIsAdded_And_Requesting_ParentType_ThenGetShouldInstance()
		{
		}
		[Fact]
		public void InMemoryCache_SetOrAdd_WhenValueIsAnObject_ThenGetShouldReturnSameObject()
		{
			_implementation.SetOrAdd(_someKey, someObject);
		}
		[Fact]
		public void InMemoryCache_SetOrAdd_WhenValueIsAnString_ThenGetShouldReturnSameObject()
		{
			_implementation.SetOrAdd(_someKey, someObject);
			_implementation.Get<string>(_someKey).ShouldBe(someObject);
		}
		[Fact]
		public void InMemoryCache_SetOrAdd_WhenValueIsAnInt_ThenGetShouldReturnSameObject()
		{
			_implementation.SetOrAdd(_someKey, someObject);
		}
		[Fact]
		public void InMemoryCache_ContainsKey_WhenKeyIsNull_ThenShouldThrowArgumentNullException()
		{
			Should.Throw<ArgumentNullException>(() => _implementation.ContainsKey(null));
		}
		[Fact]
		public void InMemoryCache_Get_WhenKeyIsNull_ThenShouldThrowArgumentNullException()
		{
			Should.Throw<ArgumentNullException>(() => _implementation.Get<object>(null));
		}
		[Fact]
		public void InMemoryCache_ContainsKey_WhenAnValueWasAdded_ThenShouldReturnTrue()
		{
		}
		[Fact]
		public void InMemoryCache_ContainsKey_WhenAnValueWasNotAdded_ThenShouldReturnFalse()
		{
		}
		[Fact]
		public void InMemoryCache_Get_WhenAnValueWasNotAdded_ThenShouldThrowArgumentException()
		{
			Should.Throw<ArgumentException>(() => _implementation.Get<object>("NotExistingKey"));
		}
		[Fact]
		public void InMemoryCache_Get_WhenAnValueOfDifferentTypeWasAdded_ThenShouldThrowException()
		{
				.Throw<ArgumentException>(
					() => _implementation.Get<OtherObject>(_someKey))
				.Message.StartsWith($"Aan InMemoryCache is gevraagd om key {_someKey} op te vragen met type OtherObject");
		}
		[Fact]
		public void InMemoryCache_Get_WhenValueIsAString_And_RequestingUri_ThenShouldThrowException()
		{
			Should
				.Throw<ArgumentException>(
					() => _implementation.Get<Uri>(_someKey))
				.Message.StartsWith($"Aan InMemoryCache is gevraagd om key {_someKey} op te vragen met type ");
		}

		[Fact]
		public void InMemoryCache_Get_WhenAnValueOfDifferentTypeWasAdded_ThenShouldThrow()
		{
				.Throw<ArgumentException>(() => _implementation.Get<Uri>(_someKey))
				.Message.StartsWith($"Aan InMemoryCache is gevraagd om key {_someKey} op te vragen met type ");
		}
		{
		{
		{
		}
		{
	}
}