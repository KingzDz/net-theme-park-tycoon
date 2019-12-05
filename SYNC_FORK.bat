@echo off

REM Manual instructions: https://help.github.com/en/github/collaborating-with-issues-and-pull-requests/syncing-a-fork

echo Check if upstream exists
git ls-remote upstream

if errorlevel 1 (
    echo Upstream to original repository did not exist. Adding it.
    git remote add upstream https://github.com/timothywalter/net-theme-park-tycoon.git
)

echo Getting latest version from upstream
git fetch upstream

echo Switching to our fork's local master branch
git checkout master

echo Merge changes from upstream into our local master
git merge upstream/master