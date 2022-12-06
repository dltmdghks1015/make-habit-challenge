### Project) 오락실 Pang 게임 만들기 ###

## [게임 조건] ##
# 1. 캐릭터는 화면 아래에 위치, 좌우로만 이동 가능
# 2. 스페이스를 누르면 무기를 쏘아 올림
# 3. 큰 공 1개가 나타나서 바운스
# 4. 무기에 닿으면 공은 작은 크기 2개로 분할, 가장 작은 크기의 공은 사라짐
# 5. 모든 공을 없애면 게임 종료 (성공)
# 6. 캐릭터는 공에 닿으면 게임 종료 (실패)
# 7. 시간 제한 99초 초과 시 게임 종료 (실패)
# 8. FPS 는 30 으로 고정 (필요시 speed 값을 조정)

## [게임 이미지] ##
# 1. 배경 : 640 * 480(가로 세로) - background_project.png
# 2. 무대 : 640 * 50 - stage.png
# 3. 캐릭터 : 33 * 60 - character_project.png
# 4. 무기 : 20 * 430 - weapon.png
# 5. 공 : 160 * 160, 80 * 80, 40 * 40, 20 * 20 - balloon1.png ~ balloon4.png

import pygame
############################################################
# 기본 초기화 (반드시 해야 하는것들)
pygame.init() # 초기화 (반드시 필요)

# 화면 크기 설정
screen_width = 640 # 가로 크기
screen_height = 480 # 세로 크기
screen = pygame.display.set_mode((screen_width, screen_height))

# 화면 타이틀 설정
pygame.display.set_caption("Pang Game")

# FPS
clock = pygame.time.Clock()
############################################################

# 1. 사용자 게임 초기화 (배경화면, 게임 이미지, 좌표, 속도, 폰트 등)
background = pygame.image.load(("E:/Python game/pygame_basic/background_project.png"))

stage = pygame.image.load("E:/Python game/pygame_basic/stage.png")
stage_size = stage.get_rect().size
stage_width = stage_size[0]
stage_height = stage_size[1]

character = pygame.image.load("E:/Python game/pygame_basic/character_project.png")
character_size = character.get_rect().size
character_width = character_size[0]
character_height = character_size[1]
character_x_pos = (screen_width / 2) - (character_width / 2)
character_y_pos = screen_height - stage_height - character_height

character_speed = 0.6

to_x = 0

# weapon = 

# balloon1 = pygame.image.load("E:/Python game/pygame_basic/balloon1.png")
# balloon2 = pygame.image.load("E:/Python game/pygame_basic/balloon2.png")
# balloon3 = pygame.image.load("E:/Python game/pygame_basic/balloon3.png")
# balloon4 = pygame.image.load("E:/Python game/pygame_basic/balloon4.png")


running = True 
while running:
    dt = clock.tick(30) # 게임화면의 초당 프레임 수를 설정

    # 2. 이벤트 처리 (키보드, 마우스 등)
    for event in pygame.event.get(): 
        if event.type == pygame.QUIT: 
            running = False 

        if event.type == pygame.KEYDOWN:
            if event.key == pygame.K_LEFT:
                to_x -= character_speed
            elif event.key == pygame.K_RIGHT:
                to_x += character_speed

        if event.type == pygame.KEYUP:
            if event.key == pygame.K_LEFT or event.key == pygame.K_RIGHT:
                to_x = 0

    # 3. 게임 캐릭터 위치 정의
    character_x_pos += to_x * dt

    if character_x_pos < 0:
        character_x_pos = 0
    elif character_x_pos > screen_width - character_width:
        character_x_pos = screen_width - character_width

    # 4. 충돌 처리
    character_rect = character.get_rect()
    character_rect.left = character_x_pos
    character_rect.top = character_y_pos

    # 5. 화면 그리기
    screen.blit(background,(0,0))

    screen.blit(stage,(0,(screen_height - stage_height)))

    screen.blit(character,(character_x_pos,character_y_pos))

    pygame.display.update() # 게임화면을 다시 그리기


pygame.quit