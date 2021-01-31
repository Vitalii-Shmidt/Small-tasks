// ref: https://www.codewars.com/kata/5884a4642a8d88df67000026

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace KataSocialNetwork
{
    public class SocialNetwork : ISocialNetwork
    {
        // Adds a new member and returns the added member
        public IMember AddMember(string firstName, string lastName, string city, string country)
        {
            return null;
        }

        // Returns the member with the id
        public IMember FindMemberById(int id)
        {
            return null;
        }

        // Returns a list of members by searching all fields in the profile
        public IEnumerable<IMember> FindMember(string search)
        {
            return null;
        }

        // Total number of members currently in the social network
        public int MemberCount { get { return 0;} }
    }

    public class Member : IMember
    {
        // Id of member. Must be unique and sequential. 
        public int Id { get; }
        // Member profile
        public IMemberProfile Profile { get; }
        // List of friends
        public IEnumerable<IMember> Friends { get { return null; } }
        // List of pending friend requests
        public IEnumerable<IMember> Pending { get { return null; } }
        // Members posts
        public IEnumerable<IPost> Posts { get { return null; } }

        // Adds a friend request for this member. from - the member making the friend request 
        public void AddFriendRequest(IMember from)
        {
            
        }

        // Confirms a pending friend request
        public void ConfirmFriend(IMember member)
        {
            
        }

        // Removes a pending friend request
        public void RemoveFriendRequest(IMember member)
        {
            
        }

        // Removes a friend
        public void RemoveFriend(IMember member)
        {
            
        }

        // Returns a list of all friends. level - depth (1 - friends, 2 - friends of friends ...)
        public IEnumerable<IMember> GetFriends(int level = 1, IList<int> filter = null)
        {
            return null;
        }

        // Adds a new post to members feed
        public IPost AddPost(string message)
        {
            return null;
        }

        // Removes the post with the id
        public void RemovePost(int id)
        {
            
        }

        // Returns members feed as a list of posts. Should also return posts of friends.
        public IEnumerable<IPost> GetFeed()
        {
            return null;
        }
    }

    public class MemberProfile : IMemberProfile
    {
        // Id of the Member this profile belongs to
        public int MemberId { get; set; }
        
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }

    public class Post : IPost
    {
        // Id of post. Must be unique and sequential.
        public int Id { get; set; }
        // Member that made this post
        public IMember Member { get; set; }
        // The post message
        public string Message { get; set; }
        // Date and time post was made
        public DateTime Date { get; set; }
        // Likes for post
        public int Likes { get; set; }
    }
}