using NSpec;

namespace BDD.Specs
{
    class describe_some_class : nspec
    {
        void given_true_is_true()
        {
            it["true is true"] = () => true.should_be_true();
        }
    }
}
