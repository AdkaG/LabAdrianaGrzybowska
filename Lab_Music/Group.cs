using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Music
{
    class Group : Artist
    {
        Member[] members = new Member[0];

        public Member this[int index]
        {

            get
            {
                if (index >= 0 && index <members.Length)
                    return members[index];
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }

            
        }

        public override string ToString()
        {
            string allMembersInGroup = "";
            foreach (var item in members)
            {
                allMembersInGroup += item;
            }
            return $"{base.ToString()}, {allMembersInGroup}";
        }

        public void AddMember(Member member)
        {
            Member[] temporaryMembers = new Member[members.Length + 1];
            for (int i = 0; i < members.Length; i++)
            {
                temporaryMembers[i] = members[i];
            }
            temporaryMembers[temporaryMembers.Length - 1] = member;
            members = temporaryMembers;
        }

        public void RemoveMember(Member member)
        {
            Member[] temporaryMembers = new Member[members.Length - 1];
            int indexToRemove = Array.IndexOf(members, member);
            for (int i = 0, j=0; i < members.Length; i++)
            {
                if (i == indexToRemove)
                    continue;
                temporaryMembers[j] = members[i];
                j++;
            }
            members = temporaryMembers;
        }
    }
}
