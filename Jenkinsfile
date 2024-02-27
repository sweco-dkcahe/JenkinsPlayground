pipeline {
    agent any

    stages {
        stage(''){
            steps{
                cleanWs()
            }
        }
        stage('Restoring'){
            steps{
                echo 'Restore'
                echo 'Running in ${env.WORKSPACE} on ${env.JENKINS_URL}'
                bat 'cd JenkinsAPI'
                bat 'dotnet restore'
            }
        }
        stage('Testing'){
            steps{
                echo 'Testing.....'
                bat 'dotnet test'
            }
        }
        stage('Build') {
            steps {
                echo 'Building..'
                bat 'dotnet build'
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
            }
        }
        stage('Publish')
        {
            steps{
                echo 'Publishing'
                bat 'dotnet publish -c Release -o out/'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
                bat 'move out\\* E:\\INetPub\\JekninsInnoDay\\CAHE '
            }
        }
    }
}