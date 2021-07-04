```csharp
Sentence sentence = SentenceFactory.CreateSentence("You do it");

sentence.Perfect().Past();

string str = sentence.ToString();

Assert.Equal("You had done it", str);
```