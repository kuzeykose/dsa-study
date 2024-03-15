cmake_minimum_required(VERSION 3.10)
project(Implementation)

set(CMAKE_CXX_STANDARD 20)

set(SRC_DIR "${CMAKE_SOURCE_DIR}/src")
set(TESTS_DIR "${CMAKE_SOURCE_DIR}/tests")

file(GLOB SRC_FILES "${SRC_DIR}/*.cpp")

add_executable(main ${SRC_FILES})

set_target_properties(main PROPERTIES
    RUNTIME_OUTPUT_DIRECTORY "${CMAKE_BINARY_DIR}/bin"
)

include_directories("${CMAKE_SOURCE_DIR}/include")

find_package(GTest REQUIRED)

set(TEST_EXECUTABLE_NAME "main_test")

file(GLOB TEST_SRC_FILES "${TESTS_DIR}/*.cpp")

add_executable(${TEST_EXECUTABLE_NAME} ${TEST_SRC_FILES})

set_target_properties(${TEST_EXECUTABLE_NAME} PROPERTIES
    RUNTIME_OUTPUT_DIRECTORY "${CMAKE_BINARY_DIR}/bin"
)

target_link_libraries(${TEST_EXECUTABLE_NAME} GTest::GTest GTest::Main)

enable_testing()
add_test(NAME ${TEST_EXECUTABLE_NAME} COMMAND ${TEST_EXECUTABLE_NAME})

