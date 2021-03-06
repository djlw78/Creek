using System;
using Creek.Rules.Runtime;

namespace Creek.Rules.TestFramework
{
    public class TestContext
    {
        readonly DotNetRulesContext _DotNetRulesContext;

        public TestContext(Type policy)
        {
            _DotNetRulesContext = new DotNetRulesContext(policy);
        }

        public bool WasConditionFullfilled()
        {
            return _DotNetRulesContext.WasGiven();
        }

        public TSubject Execute<TSubject>(TSubject subject)
        {
            _DotNetRulesContext.Establish(subject);
            if (_DotNetRulesContext.Given())
            {
                _DotNetRulesContext.Then(false);
            }
            _DotNetRulesContext.Finally();
            subject = _DotNetRulesContext.Return<TSubject>();
            return subject;
        }

        public TSource Execute<TSource, TTarget>(TSource source, TTarget target)
        {
            _DotNetRulesContext.Establish(source, target);
            if (_DotNetRulesContext.Given())
            {
                _DotNetRulesContext.Then(false);
            }
            _DotNetRulesContext.Finally();
            source = _DotNetRulesContext.Return<TSource>();
            return source;
        }
    }
}
