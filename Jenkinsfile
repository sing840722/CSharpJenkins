pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
				bat 'dotnet build'
            }
        }
        stage('Test') {
            steps {
                bat 'dotnet test'
            }
        }
        stage('Deploy') {
            steps {
				echo 'Deploying...'
				bat 'git add .'
				bat 'git commit -m "commit dev"'
				bat 'git checkout master'
				bat 'git merge (env.BRANCH_NAME)'
			}
        }
    }
	post {
	always{
		echo 'I have Finished'
		deleteDir()
		}
	}
}