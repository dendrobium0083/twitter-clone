using System;
using Twitter.Domain.Entities;
using Twitter.Domain.Exceptions;
using Twitter.Domain.ValueObjects;
using Xunit;

namespace Twitter.Domain.Tests.Entities
{
    public class TweetTests
    {
        [Fact]
        public void Constructor_ValidParameters_ShouldCreateTweet()
        {
            // Arrange
            var id = 1L;
            var userId = 1L;
            var content = new TweetContent("テストツイート");

            // Act
            var tweet = new Tweet(id, userId, content);

            // Assert
            Assert.Equal(id, tweet.Id);
            Assert.Equal(userId, tweet.UserId);
            Assert.Equal(content, tweet.Content);
            Assert.False(tweet.IsDeleted);
            Assert.True(tweet.CreatedAt <= DateTime.UtcNow);
        }

        [Fact]
        public void Constructor_InvalidId_ShouldThrowValidationException()
        {
            // Arrange
            var userId = 1L;
            var content = new TweetContent("テストツイート");

            // Act & Assert
            Assert.Throws<ValidationException>(() => new Tweet(0, userId, content));
        }

        [Fact]
        public void Constructor_InvalidUserId_ShouldThrowValidationException()
        {
            // Arrange
            var id = 1L;
            var content = new TweetContent("テストツイート");

            // Act & Assert
            Assert.Throws<ValidationException>(() => new Tweet(id, 0, content));
        }

        [Fact]
        public void Constructor_NullContent_ShouldThrowArgumentNullException()
        {
            // Arrange
            var id = 1L;
            var userId = 1L;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new Tweet(id, userId, null!)); // null! を使用して警告を抑制
        }

        [Fact]
        public void Edit_ValidContent_ShouldUpdateContent()
        {
            // Arrange
            var tweet = new Tweet(1, 1, new TweetContent("初期ツイート"));
            var newContent = new TweetContent("編集後のツイート");

            // Act
            tweet.Edit(newContent);

            // Assert
            Assert.Equal(newContent, tweet.Content);
        }

        [Fact]
        public void Edit_NullContent_ShouldThrowArgumentNullException()
        {
            // Arrange
            var tweet = new Tweet(1, 1, new TweetContent("初期ツイート"));

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => tweet.Edit(null!)); // null! を使用して警告を抑制
        }

        [Fact]
        public void Delete_ShouldSetIsDeletedToTrue()
        {
            // Arrange
            var tweet = new Tweet(1, 1, new TweetContent("削除対象ツイート"));

            // Act
            tweet.Delete();

            // Assert
            Assert.True(tweet.IsDeleted);
        }
    }
}