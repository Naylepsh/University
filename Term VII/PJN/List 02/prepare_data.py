from random import randint

filenames = ['korpus_orzeszkowej.txt',
             'korpus_prusa.txt', 'korpus_sienkiewicza.txt']
for filename in filenames:
    with open(f'dane/teaching_{filename}', 'w+', encoding='utf-8') as teaching_set:
        with open(f'dane/{filename}', 'r', encoding='utf-8') as infile:
            with open(f'dane/validation_{filename}', 'w+', encoding='utf-8') as validation_set:
                for line in infile:
                    if len(line.rstrip('\n')) == 0:
                        continue
                    chance = randint(0, 10)
                    if chance < 1:
                        validation_set.write(line)
                    else:
                        teaching_set.write(line)
