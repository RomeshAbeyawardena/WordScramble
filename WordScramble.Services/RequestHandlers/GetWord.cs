using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WordScramble.Contracts;
using WordScramble.Domains;
using WordScramble.Domains.Constants;
using WordScramble.Domains.Extensions;
using GetWordRequest = WordScramble.Domains.Requests.GetWord;
using GetWordResponse = WordScramble.Domains.Responses.GetWord;

namespace WordScramble.Services.RequestHandlers
{
    public class GetWord : ResultRequestHandlerBase<GetWordRequest, GetWordResponse, string>
    {
        private readonly ApplicationSettings applicationSettings;
        private readonly IWordDictionaryService wordDictionaryService;
        private readonly IRandomNumberGenerator randomNumberGenerator;

        public override async Task<GetWordResponse> Handle(GetWordRequest request, CancellationToken cancellationToken)
        {
            var word = string.Empty;
            while (word.Length > request.MinimumLength)
            {
                word = await wordDictionaryService
                        .GetWordAtLineIndexFromDictionary(
                            FileExtensions.GetFile(applicationSettings.DictionaryPath),
                            randomNumberGenerator
                                .GetRandomNumber(General.MaximumDictionaryLineIndex));
            }
            return Success(word);
        }

        public GetWord(
            ApplicationSettings applicationSettings,
            IWordDictionaryService wordDictionaryService,
            IRandomNumberGenerator randomNumberGenerator)
        {
            this.applicationSettings = applicationSettings;
            this.wordDictionaryService = wordDictionaryService;
            this.randomNumberGenerator = randomNumberGenerator;
        }
    }
}
