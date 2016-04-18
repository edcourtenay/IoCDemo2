using System;
using System.Collections.Concurrent;
using System.Linq;
using Moq;
using NUnit.Framework;

namespace WebFilm.Tests
{
    public abstract class BehaviourTest<T> where T : class 
    {
        private readonly ConcurrentDictionary<Type, Mock> _mocks
            = new ConcurrentDictionary<Type, Mock>();

        private readonly Lazy<T> _sut;

        protected BehaviourTest()
        {
            _sut = new Lazy<T>(CreateSut);
        }

        public Mock<TMock> GetMock<TMock>() where TMock : class
        {
            return (Mock<TMock>) GetMock(typeof (TMock));
        }

        private Mock GetMock(Type type)
        {
            return _mocks.GetOrAdd(type, mockType =>
            {
                var genericType = typeof (Mock<>).MakeGenericType(mockType);
                return (Mock) Activator.CreateInstance(genericType);
            });
        }

        private T CreateSut()
        {
            var constructorInfo = typeof(T).GetConstructors()
                .OrderByDescending(info => info.GetParameters().Length)
                .First();

            var parameters = constructorInfo.GetParameters()
                .Select(info => GetMock(info.ParameterType))
                .Select(mock => mock.Object)
                .ToArray();

            return (T) Activator.CreateInstance(typeof (T), parameters);
        }

        public T Sut()
        {
            return _sut.Value;
        }

        [SetUp]
        public void Setup()
        {
            Given();

            When();
        }

        protected abstract void Given();

        protected abstract void When();
    }
}