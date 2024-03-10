s = " "

all_answers = []
answer = []
for i in s:
    if not i in answer:
        answer.append(i)
    else:
        all_answers.append(answer)
        answer = []
        answer.append(i)
highest_len = 0
for i in all_answers:
    if len(i) > highest_len:
        highest_len = len(i)
print(highest_len)