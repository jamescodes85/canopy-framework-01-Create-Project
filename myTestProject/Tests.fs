module Tests

open NUnit.Framework
open canopy.classic

[<TestFixture>]
type TestCases() =

    [<TestCase(TestName="My First Test", Category="Test Cases")>]
        member _.My_First_Test() =
            start chrome
            url "http://lefthandedgoat.github.io/canopy/testpages/"
            clear "#testfield1"
            "#testfield1" << "Test field 1 input"
            click "#button"
            click "#hyperlink"